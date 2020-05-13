import { Component, OnInit } from '@angular/core';

import { ClientService } from '../services/client.service';
import { ApoyoService } from '../services/donate.service';
import { Persona } from '../models/persona';
import { Apoyo } from '../models/apoyo';

import { Location } from '@angular/common';

@Component({
  selector: 'app-donate',
  templateUrl: './donate.component.html',
  styleUrls: ['./donate.component.css']
})
export class DonateComponent implements OnInit {

  apy: Apoyo;
  psn: Persona;

  constructor(private cS:ClientService, private apyS:ApoyoService, private location:Location) {
    this.apy = new Apoyo();
  }

  ngOnInit() {
    this.psn = this.cS.read();
  }

  fecha():string{
    return this.apy.fecha.toLocaleString();
  }

  confirmar():void{
    this.apy.persona = this.psn.identificacion;
    this.apyS.post(this.apy).subscribe(
      (data) => {
        alert('Guardado');
      },
      (error) => {
        alert('Error al registrar el apoyo');
      }
    );
    this.cS.clear();
    this.location.back();
  }

}
