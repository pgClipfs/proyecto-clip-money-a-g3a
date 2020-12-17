import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';

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

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService
  ) { }

  ngOnInit(): void {
    this.returnUrl = this.route.snapshot.queryParams.returnUrl || '/';
    console.log("aca se esta creando");
  }


  onSubmit(): void {
    console.log("llamamos a la funcion onsubmit");
    console.log("el usuario es" + this.usernameControl.value);
    console.log("contraseña es " + this.passwordControl.value);
    // despues borrar todos los console.log

    this.authenticationService.login(this.usernameControl.value, this.passwordControl.value)
      .subscribe(
          data => {
              this.router.navigate([this.returnUrl]);
              console.log("paso el usuario y contraseña");
        },
        error => {
            this.error = error;
          }
        );
  }
}
