import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';

import { AuthenticationServices } from '../services/AuthenticationServices'

/*
Log In Component

Description: The component that does a majority of the heavy lifting around user authentication aside from the 
Authentication Service and the Route Guard. This component defines the form which is where web users input their credentials
and then handles the response returned from the API once the data has been delivered in the request.


*/
@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {
  newForm: FormGroup;
  submitted = false;
  error: string = "";

  //Instantiates interfaces and services pertaining to routes, forms and the authentication.
  constructor(private formBuilder : FormBuilder,
    private router: Router,
    private authenticationServices: AuthenticationServices
    ){
      // In a scenario where the user has not logged in, the router will navigate to the login page which is rerouted from ''.
      if (this.authenticationServices.userValue) { 
        this.router.navigate(['']);
      }
    }

  // Initializes the form and ensures that both fields are filled in before a submission is accepted. 
  ngOnInit(): void {
    this.newForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  // Used to access form parameters easily within the functions and within the html code.
  get form() { return this.newForm.controls; }

  onSubmit() :void {
    this.submitted = true;
    // In a scenario where the form details are invalid then the submission is cancelled.
    if (this.newForm.invalid) {
      return;
    }
    // If form is valid then, the authentication service is passed the username and password to make the authentication api call.
    this.authenticationServices.login(this.form.username.value, this.form.password.value)
        .pipe(first())
        .subscribe(
            // If correct credentials then success is returned
            successResponse => {
              // User must be an admin to login to the client.
              if (successResponse.role == "admin")
                this.router.navigate(['/clients']);
              else
                this.error = "Only admins/supervisors may access this client."
            },
            // If incorrect, the failure is scanned from the response and output to the page.
            failedResponse => {
                this.error = failedResponse.error.message;
                console.log(this.error);
            });
  }
}
