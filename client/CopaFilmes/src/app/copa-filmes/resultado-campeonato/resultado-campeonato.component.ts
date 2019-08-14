import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Filme } from '../models/filme';

@Component({
  selector: 'cf-resultado-campeonato',
  templateUrl: './resultado-campeonato.component.html',
  styleUrls: ['./resultado-campeonato.component.css']
})
export class ResultadoCampeonatoComponent implements OnInit {

  state$: Observable<object>;
  filmesVencedores: Filme[] = [];


  constructor(private router: Router) {}

  ngOnInit() {
    this.filmesVencedores = JSON.parse(localStorage.getItem('resultado-campeonato')).data.filmes;
    console.log(this.filmesVencedores)
  }
}
