import { Component, OnInit } from '@angular/core';
import { AuthServiceService} from '../../../services/auth-service.service'
import { FormControl, Validators } from '@angular/forms';
@Component({
  selector: 'app-transferencia',
  templateUrl: './transferencia.component.html',
  styleUrls: ['./transferencia.component.sass']
})
export class TransferenciaComponent implements OnInit {
submitted =false ;
valorControl = new FormControl('', Validators.required);
  constructor(public auth: AuthServiceService) { }


  parseInt(
    arg
  ){
    if(arg){
    return parseInt(arg)
    }else{return 0}
  }
  onSubmit(){
    this.auth.restMoney(this.valorControl.value);
    this.submitted = true;
    setTimeout(()=>{this.submitted = false}, 2000)
  }

  ngOnInit(): void {
  }

}
