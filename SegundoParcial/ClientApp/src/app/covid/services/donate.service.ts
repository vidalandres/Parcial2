import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Apoyo } from '../models/apoyo';
import { Observable } from 'rxjs';
import { HandleHttpErrorService } from '../../@base/handle-http-error.service';
import {catchError, map, tap} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApoyoService {

  baseUrl: string;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) 
  {
    this.baseUrl = baseUrl;
  }

  post(apy: Apoyo): Observable<Apoyo> {
    return this.http.post<Apoyo>(this.baseUrl + 'api/apoyo', apy)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Apoyo>('Registrar Apoyo', null))
    );
  }

}
