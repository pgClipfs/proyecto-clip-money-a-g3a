import { RouterModule, Routes, CanActivate} from '@angular/router';
import { HomeComponent } from './components/shared/home/home.component';
import { LoginComponent } from './components/shared/login/login.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { TestScreenComponent } from './components/test-screen/test-screen.component';
import { AuthGuardGuard }from './guards/auth-guard.guard'




const APP_ROUTES: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'login', component: LoginComponent},
    { path: 'register', component: RegisterComponent },
    { path: 'test', component: TestScreenComponent, canActivate: [AuthGuardGuard]},
    { path: '**', pathMatch: 'full', redirectTo: 'home' },

];

export const APP_ROUTING = RouterModule.forRoot( APP_ROUTES);

// , { useHash : true} //
