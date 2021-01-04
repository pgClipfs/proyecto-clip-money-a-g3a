import { Component, OnInit } from '@angular/core';
import { AuthServiceService } from '../../../services/auth-service.service'
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.sass']
})
export class NavbarComponent implements OnInit {
  isLogged : boolean
  constructor(public auth: AuthServiceService) { 
    this.isLogged = auth.authenticated
    
  }

  ngOnInit(): void {
  }

}
