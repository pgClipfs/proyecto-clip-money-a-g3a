import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';

@Component({
  selector: 'app-modificar-datos',
  templateUrl: './modificar-datos.component.html',
  styleUrls: ['./modificar-datos.component.sass']
})
export class ModificarDatosComponent implements OnInit {
  returnUrl: string;
  error = '';
  modifyEmail = new FormControl('', Validators.required);
  modifyHome = new FormControl('', Validators.required);
  modifyTelephone = new FormControl('', Validators.required);
  modifyPassword = new FormControl('', Validators.required);


  hide = true;

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    console.log("llamamos a la funcion onsubmit");
    console.log(this.modifyEmail.value,
      this.modifyEmail.value,
      this.modifyHome.value,
      this.modifyTelephone.value,
      this.modifyPassword.value);

  }


}
