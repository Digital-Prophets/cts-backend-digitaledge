import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})


export class MissedAppointmentService {
 
  constructor(private _http: HttpClient) {
  }

  getAppointmentsMissedFilter(user: any) {
    return this._http.post<any>('/api/Visit/ViewAppointmentsMissedFilter', user, httpOptions);
  }
 
}