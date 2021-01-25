/*
User Interface

Description: The User interface is used within local storage to keep track of authentication and permissions.
The role property will determine whether the user can access the data and the authInfo property will
contain the key used to make additonal requests to the API.
*/
export interface User {
    role: string;
    authInfo? : string;
}