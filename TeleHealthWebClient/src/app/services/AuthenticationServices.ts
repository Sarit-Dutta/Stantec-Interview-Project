import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { User } from '../entities/User';

/*
Authentication Services

Description: Handles the user login and logout functionality of the web client. Makes use of a Behaviour Subject and an
associated Observable in order to keep track of information pertaining to access to the API as well as to different
routes on the web client. The Observable is kept to enable and disable the logout button on the base app component. The 
Behaviour Subject is kept to keep track of whether access is permitted to the client record route on the web client.
*/
@Injectable({ providedIn: 'root' })
export class AuthenticationServices {
    private userSubject : BehaviorSubject<User>;
    public userObservable : Observable<User>;

    //Sets the login status and base user info that the login and logout functionality will use.
    //The Behaviour Subject pulls the user info from local storage so that other components have vision of data that is present.
    constructor(private http: HttpClient) {
        localStorage.setItem('LoggedIn', 'false');
        localStorage.setItem('currentUser', JSON.stringify({role: 'none'}));
        this.userSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
        this.userObservable = this.userSubject.asObservable();
    }

    // Function that allows components to extract data from the Behaviour Subject when required.
    public get userValue(): User {
        return this.userSubject.value;
    }

    // Login Function that is passed a username and password from the login component to validate credentials
    login(username: string, password: string) {
        // Makes the request to the api.
        return this.http.post<any>('https://localhost:5001/api/user/authenticate', { username, password }, {
            headers: { 
                Authorization: `Basic ${window.btoa(username + ":" + password)}`
            }})
        .pipe(map(user => {
            // Stores user details and basic auth credentials in local storage to keep user logged in between page refreshes.
            user.authInfo = window.btoa(username + ":" + password);
            localStorage.setItem('currentUser', JSON.stringify({user}));
            localStorage.setItem('LoggedIn', 'true');
            this.userSubject.next(user);
            return user;
        }));
    }

    // When logout is called it removes data pertaining to the logged in user and sets the Logged In status to false
    // The userSubject variable is also reset to reflect no existing role for authentication.
    logout() {
        localStorage.removeItem('currentUser');
        localStorage.setItem('LoggedIn', 'false');
        this.userSubject.next({role: 'none'});
    }
}