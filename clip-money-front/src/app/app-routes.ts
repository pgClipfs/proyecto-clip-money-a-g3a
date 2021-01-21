import { RouterModule, Routes, CanActivate} from '@angular/router';
import { HomeComponent } from './components/shared/home/home.component';
import { LoginComponent } from './components/shared/login/login.component';
import { Register2Component } from './components/shared/register2/register2.component';
import { RetirarComponent } from './components/shared/retirar/retirar.component';
import { ConsultarComponent } from './components/shared/consultar/consultar.component';
import { IngresarComponent } from './components/shared/ingresar/ingresar.component';
import { ModificarDatosComponent } from './components/shared/modificar-datos/modificar-datos.component';
import { MovimientosComponent } from './components/shared/movimientos/movimientos.component';
import { TransferenciaComponent } from './components/shared/transferencia/transferencia.component';
import { TestScreenComponent } from './components/test-screen/test-screen.component';
import { AuthGuardGuard }from './guards/auth-guard.guard'


const APP_ROUTES: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'login', component: LoginComponent},
    { path: 'register2', component: Register2Component },
    { path: 'consultar', component: ConsultarComponent },
    { path: 'retirar', component: RetirarComponent },
    { path: 'ingresar', component: IngresarComponent },
    { path: 'modificar-datos', component: ModificarDatosComponent },
    { path: 'movimientos', component: MovimientosComponent },
    { path: 'transferencia', component: TransferenciaComponent },
    { path: 'test', component: TestScreenComponent, canActivate: [AuthGuardGuard]},
    { path: '**', pathMatch: 'full', redirectTo: 'login' },

];

export const APP_ROUTING = RouterModule.forRoot( APP_ROUTES);

// , { useHash : true} //
