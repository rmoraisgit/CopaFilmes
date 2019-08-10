import { Component, OnInit } from '@angular/core';

import { Filme } from '../models/filme';
import { FilmeServices } from '../services/filme.service';

@Component({
  selector: 'cf-inicio-jogo',
  templateUrl: './inicio-jogo.component.html',
  styleUrls: ['./inicio-jogo.component.css']
})
export class InicioJogoComponent implements OnInit {

  filmes: Filme[] = [];
  quantidadeSelecionada: number = 5;

  constructor(private filmeService: FilmeServices) { }

  ngOnInit() {
    this.filmeService.obterFilmes().subscribe(filmes => {
      this.filmes = filmes;
      console.log(this.filmes);
    })
  }
}