import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LoanService {

  constructor(
    private http: HttpClient) { }

  register(userRegistration: any) {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json'
    });
    let options = { headers: headers };
    return this.http.post("http://" + '/register', userRegistration, options)
      .pipe(
        map((data: any) => {
          return data;
        }), catchError(error => {
          return throwError(error);
        })
      )
  }
}
