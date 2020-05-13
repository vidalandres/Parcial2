import { Component, OnInit } from '@angular/core';
import { Persona } from '../models/persona';

import { PersonaService } from '../services/persona.service';

@Component({
  selector: 'app-record',
  templateUrl: './record.component.html',
  styleUrls: ['./record.component.css']
})
export class RecordComponent implements OnInit {

  psn:Persona;

  constructor(private pS:PersonaService) { 
    this.psn = new Persona();
  }

  ngOnInit() {
  }

  add():void{
    console.log(this.psn);
    this.pS.post(this.psn).subscribe(
      (data) => {
        if(data!=null) {
          alert('Guardado');
          this.psn = data;
        }
      }
    );
  }

  clear():void{
    this.psn = new Persona();
  }

}
