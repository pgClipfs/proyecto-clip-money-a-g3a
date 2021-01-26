import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
import { MatDrawer } from '@angular/material/sidenav';
import { AuthServiceService}from '../../../services/auth-service.service';
import { AppComponent } from '../../../app.component';
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


  constructor(private auth : AuthServiceService,private renderer: Renderer2, private comp: AppComponent){
    this.username = this.auth.user.user;
  }

  clickDrawer(){

    this.comp.title = "asdasd"
    console.log( this.comp.title)
    setTimeout(()=>{
      this.renderer.selectRootElement(this.drawer.toggle());
  }, 3000);

  };

  logOut(){
    this.auth.logout()

  }
}
