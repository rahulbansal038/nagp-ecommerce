import { AuthGuard } from "./auth-guard";
import { Routes } from "../../node_modules/@angular/router";
import { HomeComponent } from "./home/home.component";
import { ProfileComponent } from "./profile/profile.component";

export const routes: Routes = [
    {
        path:'', 
        component: HomeComponent, 
        pathMatch: 'full'
    },
    {
        path:'profile', 
        component: ProfileComponent, 
        canActivate: [AuthGuard]
    },
    {
        path: '**',
        redirectTo: ''
    }
];