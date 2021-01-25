// Identifies the information that is to be displayed within the client and client details component.
export interface client {
    Id?: number;
    firstName: string;
    middleName?: string;
    lastName: string;
    phoneNumber?: string;
    address?: string;
    city?: string;
    province?: string;
    postalCode?: string;
    concerns: string;
    response: string;
}
