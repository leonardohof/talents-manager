import { Injectable } from '@angular/core';
import { Talent } from '../models/talent.model';
import { Observable, of } from 'rxjs';
import { Configuration } from '../app.constants';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TalentsService {

  KNOWLEDGES_DATA: String[] = ['Ionic', 'Android', 'iOS', 'HTML', 'CSS', 'Java', 'C#', 'ASP .NET MVC', 'AngularJs', 'Angular', 'ReactJs'];
  HEADERS = new HttpHeaders({ 'Content-Type' : 'application/json', 'Accept': 'application/json', 'Accept-Language' : 'pt-BR' });

  constructor(public config: Configuration, public http: HttpClient) { }

  getAllTalents(): Observable<Talent[]> {
    return this.http.get<Talent[]>(this.config.serverWithApiUrl + 'talents', { headers: this.HEADERS });
  }

  getTalentById(id: number): Observable<Talent> {
    return this.http.get<Talent>(this.config.serverWithApiUrl + 'talents/' + id, { headers: this.HEADERS });
  }

  add(data: Talent): Observable<any> {
    return this.http.post<Talent>(this.config.serverWithApiUrl + 'talents', data, { headers: this.HEADERS });
  }

  update(id: any, data: Talent): Observable<any> {
    return this.http.put<Talent>(this.config.serverWithApiUrl + 'talents/' + id, data, { headers: this.HEADERS });
  }

  deleteTalent(id): Observable<any> {
    return this.http.delete(this.config.serverWithApiUrl + 'talents/' + id, { headers: this.HEADERS });
  }

  getAllSkills(): Observable<String[]> {
    return of<String[]>(this.KNOWLEDGES_DATA);
  }
}
