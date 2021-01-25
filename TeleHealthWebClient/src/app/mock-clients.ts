import { client } from './client';

// mockdata for testing.  Can replace the getClients() function call in the client component.
export const mockList: client[] = [
    {Id: 1, firstName: "Sarit", lastName: "Dutta", concerns: "Gourd", response: "Pogged."},
    {Id: 2, firstName: "Ryan", middleName: "Gary", lastName: "LeTourneau", concerns: "Northern", response: "Roar."},
    {Id: 3, firstName: "Daniel", lastName: "Gheesling", concerns: "Colemans", response: "Greatest camper in the great outdoors."},
    {Id: 4, firstName: "Wazer", lastName: "Rehman", concerns: "Lets go", response: "Boi."},
    {Id: 5, firstName: "Michael", lastName: "Zhang", concerns: "Relax", response: "Bro."}
]