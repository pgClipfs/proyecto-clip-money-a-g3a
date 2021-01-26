import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
import { MatDrawer } from '@angular/material/sidenav';
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

  @ViewChild('drawer') drawer: MatDrawer;


  constructor(private auth : AuthServiceService,private renderer: Renderer2 ){
    this.username = this.auth.user.user;
  }

  clickDrawer(){
    console.log(this.drawer)

    setTimeout(()=>{
      this.renderer.selectRootElement(this.drawer.toggle());
  }, 2000);

  };

  logOut(){
    this.auth.logout()

  }



}
