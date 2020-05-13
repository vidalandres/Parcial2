import { Component, OnInit } from '@angular/core';
import { Persona } from '../models/persona';

import { PersonaService } from '../services/persona.service';
import { FormGroup, Validators, FormBuilder, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-record',
  templateUrl: './record.component.html',
  styleUrls: ['./record.component.css']
})
export class RecordComponent implements OnInit {

  registerForm: FormGroup;
  psn:Persona;

  constructor(private pS:PersonaService, private formBuilder:FormBuilder) { 
    
  }

  ngOnInit() {
    this.psn = new Persona();
    this.registerForm = this.formBuilder.group({
      identificacion:[this.psn.identificacion,Validators.required],
      nombre:[this.psn.nombre,Validators.required],
      apellido:[this.psn.apellido,Validators.required],
      sexo:[this.psn.sexo, Validators.required],
      edad:[this.psn.edad, Validators.required],
      departamento:[this.psn.departamento,Validators.required],
      ciudad:[this.psn.ciudad,Validators.required],
    });
  }

  add():void{
    this.psn = this.registerForm.value;
    console.log(this.psn);
    this.pS.post(this.psn).subscribe(
      (data) => {
        if(data!=null) {
          alert('Guardado');
          this.psn = data;
        }
        else{
          alert("Ya se ha registrado esta persona");
        }
      },
      (error) => {
        alert('Ha ocurrido un error al guardar');
      }
    );
  }

  clear():void{
    this.psn = new Persona();
  }

  get f() { return this.registerForm.controls; }

  onSumit(){
    if(this.registerForm.invalid){
      return;
    }
    this.add();
  }

}
