import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

import { AuthenticationServices } from '../services/AuthenticationServices';

/*
Route Guard Helper

Description: Implements CanActivate to ensure that the router displaying client records cannot be accessed without 
the proper credentials being provided.

canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) - This function reroutes the client
to the login page if the web user is attempting to access other routes directly without the correct authentication.
*/
@Injectable({ providedIn: 'root' })
export class routeGuard implements CanActivate {
    // The Authentication Service allows users to log in and out and determines if valid user credentials are provided.
    constructor(
        private router: Router,
        private authenticationService: AuthenticationServices
    ) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        // local storage contains the logged in user's role and auth token.
        const currentUser = this.authenticationService.userValue;
        // If a user has been correctly logged in then access is permitted.
        if (localStorage.getItem('LoggedIn') == 'true') {
            // logged in so return true
            return true;
        }

        // Invalid user or non-permitted credentials were provided which reroutes the client to the login page once again.
        this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        localStorage.setItem('LoggedIn', 'true');
        return false;
    }
}