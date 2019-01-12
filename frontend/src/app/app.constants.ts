import { Injectable } from '@angular/core';
import { environment } from '../environments/environment'

@Injectable()
export class Configuration {
    public server: string = environment.server;
    public apiUrl: string = environment.apiUrl;
    public serverWithApiUrl = this.server + this.apiUrl;
}