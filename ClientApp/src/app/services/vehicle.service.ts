import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  constructor(private http: HttpClient) { }
  getFeatures() {
    
    return this.http.get('api/features');

  }
  getMakes() {
    return this.http.get('api/makes');
  }
}
