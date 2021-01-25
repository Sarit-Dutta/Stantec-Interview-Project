import { Injectable } from '@angular/core';
import { client } from '../client';
import { AuthenticationServices } from '../services/AuthenticationServices';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';

/*
Client Service

Description: Used to make client get requests for components. Will return client records from the API
if the authentication credentials are correct.
*/
@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private clientsURL = 'https://localhost:5001/api/clients';
  constructor(private http: HttpClient, private authenticationServices: AuthenticationServices) { }

  getClients(): Observable<client[]> {
    return this.http.get<client[]>(this.clientsURL, {headers: {
      Authorization: `Basic ${this.authenticationServices.userValue.authInfo}`
    }});
  }
}
