import { Component, OnInit } from '@angular/core';
import {AuthServiceService} from 'src/app/services/auth-service.service'

@Component({
  selector: 'app-consultar',
  templateUrl: './consultar.component.html',
  styleUrls: ['./consultar.component.sass']
})
export class ConsultarComponent implements OnInit {

  hide = false;

  constructor(public auth: AuthServiceService) { }

  ngOnInit(): void {
  }

}
