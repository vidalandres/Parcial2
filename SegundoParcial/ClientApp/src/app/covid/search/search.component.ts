import { Component, OnInit } from '@angular/core';
import { Persona } from '../models/persona';

import { PersonaService } from '../services/persona.service';
import { ClientService } from '../services/client.service';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  psns:Persona[];

  constructor( private pS:PersonaService, private cS:ClientService ) {
    this.psns = new Array<Persona>();
  }

  ngOnInit() {
    this.pS.get().subscribe (
      (data) => {
        if(data==null){
          this.psns = new Array<Persona>();
          this.psns.push(new Persona());
        }
        else {
          this.psns = data;
        }
      }
    );
  }

  apoyar(id:string):void{
    this.cS.write(this.psns.find(x => x.identificacion == id));
    //location.pathname='donate';
  }

}
