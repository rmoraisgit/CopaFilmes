import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';

import { Filme } from '../models/filme';
import { FilmeServices } from '../services/filme.service';

@Component({
  selector: 'cf-inicio-jogo',
  templateUrl: './inicio-jogo.component.html',
  styleUrls: ['./inicio-jogo.component.css']
})
export class InicioJogoComponent implements OnInit {

  filmes: Filme[] = [];
  filmesSelecionados: Filme[] = [];
  quantidadeFilmesSelecionados: number = 0;

  @ViewChildren('cardsCheckBox') cardsCheckBox: QueryList<any>;

  constructor(private filmeService: FilmeServices) { }

  ngOnInit() {
    this.filmeService.obterFilmes().subscribe(filmes => {
      this.filmes = filmes;
      console.log(this.filmes);
    })
  }

  verificarQuantidadeFilmesSelecionados(event: any) {

    if (event.checked) {
      this.quantidadeFilmesSelecionados++;
      this.filmesSelecionados.push(this.filmes.find(f => f.id == event.id));
    }

    else {
      this.quantidadeFilmesSelecionados--;
      this.filmesSelecionados = this.filmesSelecionados.filter(f => f.id != event.id);
    }

    if (this.quantidadeSelecionadaCorretamente()) {
      this.bloquearCheckBox();
    }

    if (!this.quantidadeSelecionadaCorretamente() && this.checkBoxEstaBloqueado()) {
      this.desbloquearCheckBox();
      return;
    }
  }

  private quantidadeSelecionadaCorretamente(): boolean {

    console.log('QTD SELECIONADA:' + this.quantidadeFilmesSelecionados);

    if (this.quantidadeFilmesSelecionados >= 8)
      return true;

    return false;
  }

  private bloquearCheckBox() {

    this.cardsCheckBox.forEach(card => {

      if (!this.filmesSelecionados.some(f => f.id == card.idCheckBox)) {
        card.disabled = true;
        console.log('CAIU E DEVE BLOQUEARR')
      }
    });
  }

  private desbloquearCheckBox() {

    this.cardsCheckBox.forEach(card => {

      card.disabled = false;
    });
  }

  private checkBoxEstaBloqueado(): boolean {

    console.log(this.cardsCheckBox)

    if (this.cardsCheckBox.some(c => c.disabled == true)) {
      console.log('TRUE');
      return true;
    }

    else {
      console.log('FALSE');
      return false;
    }
  }

  iniciarCampeonato() {

    console.log(this.obterFilmesSelecionados());

    return this.filmeService.IniciarCampeonato(this.obterFilmesSelecionados())
      .subscribe(resp => {
        console.log(resp);
      });
  }

  private obterFilmesSelecionados() {
    return this.filmesSelecionados;
  }
}