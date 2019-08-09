import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'cf-inicio-jogo',
  templateUrl: './inicio-jogo.component.html',
  styleUrls: ['./inicio-jogo.component.css']
})
export class InicioJogoComponent implements OnInit {

  quantidadeSelecionada: number = 5;

  constructor() { }

  ngOnInit() {
  }

}
