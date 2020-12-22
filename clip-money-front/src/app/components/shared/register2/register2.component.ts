import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';

@Component({
  selector: 'app-register2',
  templateUrl: './register2.component.html',
  styleUrls: ['./register2.component.sass']
})

export class Register2Component implements OnInit {
  returnUrl: string;
  error = '';
  registerName = new FormControl('', Validators.required);
  registerLastName = new FormControl('', Validators.required);
  registerEmail = new FormControl('', Validators.required);
  registerDni = new FormControl('', Validators.required);
  registerHome = new FormControl('', Validators.required);
  registerTelephone = new FormControl('', Validators.required);
  registerUser = new FormControl('', Validators.required);
  registerPassword = new FormControl('', Validators.required);
  registerbirthdate = new FormControl('', Validators.required);


  hide = true;

  constructor() { }

  ngOnInit(): void {
  }


  onSubmit(): void {
    console.log("llamamos a la funcion onsubmit");
    console.log(this.registerName.value,
      this.registerLastName.value,
      this.registerEmail.value,
      this.registerDni.value,
      this.registerHome.value,
      this.registerTelephone.value,
      this.registerUser.value,
      this.registerPassword.value,
      this.registerbirthdate.value);

    // despues borrar todos los console.log


  }

}
