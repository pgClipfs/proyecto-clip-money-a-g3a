import { Component } from '@angular/core';
import { AuthServiceService } from './services/auth-service.service'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {
  title = 'clip-money-front';
  hide = true;
  constructor (public auth : AuthServiceService){}
}

