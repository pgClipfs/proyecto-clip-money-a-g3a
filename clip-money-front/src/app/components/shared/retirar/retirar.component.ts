import { Component, OnInit } from '@angular/core';
import { AuthServiceService} from '../../../services/auth-service.service'
import { FormControl, Validators } from '@angular/forms';
@Component({
  selector: 'app-retirar',
  templateUrl: './retirar.component.html',
  styleUrls: ['./retirar.component.sass']
})
export class RetirarComponent implements OnInit {


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

    let diferencia = parseInt( this.auth.user.money) -  parseInt( this.valorControl.value);

    if ( (diferencia < 0) && ( Math.abs(diferencia) <= 0.1*parseInt( this.auth.user.money))){
      

      this.auth.deuda = true;
      this.auth.monto_deuda = parseInt( this.auth.user.money) -  parseInt( this.valorControl.value);

      console.log( this.auth.monto_deuda)
      console.log( this.auth.deuda)

    }


    this.auth.restMoney(this.valorControl.value);
    this.submitted = true;
    setTimeout(()=>{this.submitted = false}, 2000)

    


  }

  ngOnInit(): void {
  }

}
