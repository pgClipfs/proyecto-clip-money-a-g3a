import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';
import {AuthServiceService} from 'src/app/services/auth-service.service'
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {

  returnUrl: string;
  error = '';
  usernameControl = new FormControl('', Validators.required);
  passwordControl = new FormControl('', Validators.required);
  logged : boolean;
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService,
    public auth : AuthServiceService
  ) { this.logged = this.auth.authenticated}

  ngOnInit(): void {
    this.returnUrl = this.route.snapshot.queryParams.returnUrl || '/';
    console.log("aca se esta creando");
  }


  logOut(){
    this.auth.logout()
    console.log('afuera')
  }
  onSubmit(): void {
    console.log("llamamos a la funcion onsubmit");
    console.log("el usuario es" + this.usernameControl.value);
    console.log("contraseña es " + this.passwordControl.value);
    // despues borrar todos los console.log
    this.auth.login( this.usernameControl.value , parseInt(this.passwordControl.value))


    this.authenticationService.login(this.usernameControl.value, this.passwordControl.value)
      .subscribe(
          data => {
              this.router.navigate([this.returnUrl]);
              console.log("paso el usuario y contraseña");
        },
        error => {
            // this.error = error;
          }
        );
      this.usernameControl.setValue("");
      this.passwordControl.setValue("");
  }
}
