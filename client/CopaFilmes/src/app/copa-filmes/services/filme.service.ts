import { HttpClient } from '@angular/common/http';

import { BaseService } from 'src/app/services/base.service';
import { Filme } from '../models/filme';
import { Injectable } from '@angular/core';

@Injectable({providedIn: 'root'})
export class FilmeServices extends BaseService {

    constructor(private http: HttpClient) { super(); }

    obterFilmes(){
        return this.http.get<Filme[]>(this.UrlServiceCopaFilmes, this.ObterHeaderJson());
    }
}