import { Component, OnInit } from '@angular/core';
import { AuthServiceService} from '../../../services/auth-service.service'
import { FormControl, Validators } from '@angular/forms';
@Component({
  selector: 'app-Movimientos',
  templateUrl: './movimientos.component.html',
  styleUrls: ['./movimientos.component.sass']
})
export class MovimientosComponent implements OnInit {
submitted =false ;
valorControl = new FormControl('', Validators.required);
  constructor(public auth: AuthServiceService) { }

  ngOnInit(): void {
  }

}
