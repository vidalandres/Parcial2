import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Persona } from '../models/persona';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../../@base/handle-http-error.service';
import {catchError, map, tap} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  baseUrl: string;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) 
  {
    this.baseUrl = baseUrl;
  }

  get(): Observable<Persona[]> {
    return this.http.get<Persona[]>('api/persona')
      .pipe(
        tap(_ => this.handleErrorService.log('datos recividos')),
        catchError(this.handleErrorService.handleError<Persona[]>('Consulta Persona', null))
    );
  }
  
  post(psn: Persona): Observable<Persona> {
    return this.http.post<Persona>(this.baseUrl + 'api/persona', psn)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Persona>('Registrar Persona', null))
    );
  }

}
