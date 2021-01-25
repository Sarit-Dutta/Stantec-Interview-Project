import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientsComponent } from './clients/clients.component';
import { LogInComponent } from './log-in/log-in.component';
import { routeGuard } from './helpers/routeGuard';

// Defines the routes that exist within the web client. Only login and clients are valid routes.
// Other routes are redirected to login if an attempt to access them is made.
// Route Guard is enabled for the client display route.
const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LogInComponent},
  { path: 'clients', component: ClientsComponent, canActivate: [routeGuard] },
  { path: '**', redirectTo: ''}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
