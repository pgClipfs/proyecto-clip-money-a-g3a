import { RouterModule, Routes, CanActivate} from '@angular/router';
import { HomeComponent } from './components/shared/home/home.component';
import { LoginComponent } from './components/shared/login/login.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { Register2Component } from './components/shared/register2/register2.component';
import { RetirarComponent } from './components/shared/retirar/retirar.component';
import { ConsultarComponent } from './components/shared/consultar/consultar.component';
import { IngresarComponent } from './components/shared/ingresar/ingresar.component';
import { ModificarDatosComponent } from './components/shared/modificar-datos/modificar-datos.component';
import { TestScreenComponent } from './components/test-screen/test-screen.component';
import { AuthGuardGuard }from './guards/auth-guard.guard'




const APP_ROUTES: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'login', component: LoginComponent},
    { path: 'register', component: RegisterComponent },
    { path: 'register2', component: Register2Component },
    { path: 'consultar', component: ConsultarComponent },
    { path: 'retirar', component: RetirarComponent },
    { path: 'ingresar', component: IngresarComponent },
    { path: 'modificar-datos', component: ModificarDatosComponent },
    { path: 'test', component: TestScreenComponent, canActivate: [AuthGuardGuard]},
    { path: '**', pathMatch: 'full', redirectTo: 'home' },

];

export const APP_ROUTING = RouterModule.forRoot( APP_ROUTES);

// , { useHash : true} //
