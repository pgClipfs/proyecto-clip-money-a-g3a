import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

interface user{
  money: number,
  user: string
}



@Injectable({
  providedIn: 'root'
})
  export class AuthServiceService {

  monto_deuda = 0;
  deuda = false;
  
  user = {user: null, money: null}
  authenticated: boolean;
  authChange: Subject<boolean> = new Subject<boolean>();
  userChange: Subject<user> = new Subject<user>();


  constructor() { 
    this.authChange.subscribe(value =>{this.authenticated = value})
    this.userChange.subscribe(value =>{ this.user = value})
  }

  sumMoney(money){
    this.userChange.next( {...this.user, money: parseInt(this.user.money) + parseInt(money)})
  }
  restMoney(money){
    this.userChange.next({...this.user, money: parseInt(this.user.money) - parseInt(money)})
  }
  login(username, money){
   this.userChange.next({user: username, money: money})
   this.authChange.next(true)
  }

  logout(){
    this.userChange.next({user: null, money: null})
    this.authChange.next(false)
  }

  getAuth(){
    return this.authenticated;
  }
}
