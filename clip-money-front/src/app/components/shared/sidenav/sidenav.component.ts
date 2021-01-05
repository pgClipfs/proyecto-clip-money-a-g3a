import { Component, OnInit } from '@angular/core';
import { AuthServiceService}from '../../../services/auth-service.service'
/**
 * @title Autosize sidenav
 */

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.sass']
})
export class SidenavComponent {
  showFiller = false;
  username: string;
  constructor(private auth : AuthServiceService){
    this.username = this.auth.user.user;
  }

  logOut(){
    this.auth.logout()

  }
}
