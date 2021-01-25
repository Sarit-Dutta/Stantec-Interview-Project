import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { User } from './entities/User';
import { AuthenticationServices } from './services/AuthenticationServices';

/*
App Component

Description: The base component for the web client in which all the router components are identified and displayed.
Subscribes to the authentication service observable property to show or hide the log out element.
Within html, this is referred to using the 'app-root' element.
*/
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'COVID-19 TeleHealth Web Client';
  userState: User;

  constructor(private router: Router, private authenticationServices: AuthenticationServices) {
    this.authenticationServices.userObservable.subscribe(value => this.userState = value);
  }

  // If logout is clicked, it reroutes to the login page once all authentication data has been removed from local storage.
  click() {
    this.authenticationServices.logout();
    this.router.navigate(['']);
  }
}
