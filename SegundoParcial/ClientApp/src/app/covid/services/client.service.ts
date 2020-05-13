import { Injectable } from '@angular/core';
import { Persona } from '../models/persona';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor() { }

  write(data:Persona){
    localStorage.clear();
    localStorage.setItem('psn', JSON.stringify(data));
    //SE ESCRIBIRÄ EL TOKEN EN CACHE O LOCALSTORAGE
  }

  read():Persona{
    if(null==localStorage.getItem('psn'))
      location.pathname='';
    return JSON.parse(localStorage.getItem('psn'));
    //SE DEVOLVERÄ EL CLIENTE ALAMCENADO
  }

  clear():void{
    localStorage.clear();
    location.pathname='';
  }

}
