import { Component, OnInit } from '@angular/core';
import { client } from '../client'
import { ClientService } from '../services/client.service';

/*
Client Component

Description:
Component Displays TeleHealth client records that have been pulled from the API within a table that can
be interacted with by the web client user in order to pull up additional details pertaining to a specific user.

The Component has three primary functions which are described below.

OnSelect(chosenClient: client) - The record clicked on by the user will be highlighted and passed to the child container called
app-client-details to display the concerns and response recorded and attached to the record.

onRefresh() - The component data will be reinitialized to load new information that may have been added
whilst the client was opened and populate the table accordingly.

getClients() - Makes a function call to the Client Service which will send a get request to API using the
appropriate user authentication token to retrieve records.

The selected client variable is passed down to the Client Details component as an input in order to display the data.
*/

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})
export class ClientsComponent implements OnInit {

  tempClients: client[] = [];
  constructor(private clientService: ClientService) {
  }

  ngOnInit(): void {
    this.getClients();
  }

  selectedClient: client = {
    Id: 0,
    firstName: "",
    lastName: "",
    concerns: "",
    response: ""
  };

  onSelect(chosenClient :client): void {
    this.selectedClient = chosenClient;
  }

  onRefresh() {
    this.ngOnInit();
  }

  getClients(): void {
    this.clientService.getClients()
      .subscribe(clients => this.tempClients = clients);
  }

}
