import { Component, OnInit, Input } from '@angular/core';
import { client } from '../client';


/* 
Client Details Component

Description: 
The Client Details Component displays details regarding a specific 
clients concerns and the employee response that was recorded.

Within the HTML portion of the client, this component is accessed via the element:
app-client-details

The chosen client input variable contained within the component class is used to select
the client record whose information will be brought up in the client.
*/

@Component({
  selector: 'app-client-details',
  templateUrl: './client-details.component.html',
  styleUrls: ['./client-details.component.css']
})
export class ClientDetailsComponent implements OnInit {

  @Input() chosenClient: client = {
    firstName: '',
    lastName: '',
    concerns: '',
    response: ''
  };

  constructor() { }

  ngOnInit(): void {
  }

}
