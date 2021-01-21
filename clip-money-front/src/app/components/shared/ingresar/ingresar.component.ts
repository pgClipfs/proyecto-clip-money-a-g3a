import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import {AuthServiceService} from 'src/app/services/auth-service.service'

@Component({
  selector: 'app-ingresar',
  templateUrl: './ingresar.component.html',
  styleUrls: ['./ingresar.component.sass']
})
export class IngresarComponent implements OnInit {
  valorControl = new FormControl('', Validators.required);
  submitted = true;
  constructor(private auth: AuthServiceService) { 
  
  }
  onSubmit(){
    this.auth.sumMoney(this.valorControl.value)
    this.submitted = false
    this.valorControl.setValue(0)
  }
  ngOnInit(): void {
  }

}
