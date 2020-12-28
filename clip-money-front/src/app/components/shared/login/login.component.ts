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
  }


  onSubmit(): void {
    console.log( this.usernameControl.value)
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
