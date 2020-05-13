import { Component, OnInit } from '@angular/core';
import { Persona } from '../models/persona';

import { PersonaService } from '../services/persona.service';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-record',
  templateUrl: './record.component.html',
  styleUrls: ['./record.component.css']
})
export class RecordComponent implements OnInit {

  registerForm: FormGroup;
  summitted:boolean = false;
  psn:Persona;

  constructor(private pS:PersonaService, private formBuilder:FormBuilder) { 
    this.psn = new Persona();
  }

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      id:['', Validators.required],
      nombre:['', Validators.required],
      apellido:['', Validators.required],
      sexo:['', Validators.required],
      edad:[0, Validators.required],
      departamento:['', Validators.required],
      ciudad:['', Validators.required]
    })
  }

  add():void{
    console.log(this.psn);
    this.pS.post(this.psn).subscribe(
      (data) => {
        if(data!=null) {
          alert('Guardado');
          this.psn = data;
        }
      },
      (error) => {
        alert('ha ocurrido un error al guardar')
      }
    );
  }

  clear():void{
    this.psn = new Persona();
  }

  get f() { return this.registerForm.controls; }

  onSumit(){
    this.summitted = true;
    if(this.registerForm.invalid){
      return;
    }
    this.add();
  }

  onReset() {
    this.summitted = false;
    this.registerForm.reset();
  }

}
