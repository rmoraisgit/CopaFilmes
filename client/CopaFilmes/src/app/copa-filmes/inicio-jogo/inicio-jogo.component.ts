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
  quantidadeFilmesSelecionados: number = 0;

  idFilmesSelecionados: string[] = [];
  filmesSelecionados: Filme[] = [];

  teste: any;

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
      // this.idFilmesSelecionados.push(event.id);
      this.filmesSelecionados.push(this.filmes.find(f => f.id == event.id));

      console.log(this.filmesSelecionados)

      // const index = this.idFilmesSelecionados.indexOf(event.id, 0);
      // console.log(index)
      // console.log(this.idFilmesSelecionados);
    }

    else {
      this.quantidadeFilmesSelecionados--;

      // const index = this.idFilmesSelecionados.indexOf(event.id, 0);
      // console.log(index);
      // console.log(this.idFilmesSelecionados[index])

      this.filmesSelecionados = this.filmesSelecionados.filter(f => f.id != event.id);

      // this.idFilmesSelecionados.concat(this.idFilmesSelecionados.splice(index, 1));
      console.log(this.filmesSelecionados);
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

    if (this.quantidadeFilmesSelecionados >= 3) {

      return true;
    }

    return false;
  }

  // private bloquearCheckBox(checkBoxesNaoSelecionados: string[]) {

  private bloquearCheckBox() {

    this.cardsCheckBox.forEach(card => {

      // console.log(card.idCheckBox.toString());

      // if (!this.idFilmesSelecionados.includes(card.idCheckBox, 0)) {
      //   card.disabled = true;
      //   console.log('CAIU E DEVE BLOQUEARR')
      // }

      if (!this.filmesSelecionados.some(f => f.id == card.idCheckBox)) {
        card.disabled = true;
        console.log('CAIU E DEVE BLOQUEARR')
      }

      // console.log(card);
    });
  }

  private desbloquearCheckBox() {

    this.cardsCheckBox.forEach(card => {

      card.disabled = false;
    });
  }

  private checkBoxEstaBloqueado(): boolean {
    // return this.cardsCheckBox.some(c => c.disabled == true);

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

    return this.filmeService.IniciarCampeonato(this.obterFilmesSelecionados())
      .subscribe(resp=> {
        console.log(resp);
      });
  }

  private obterFilmesSelecionados() {
    return this.filmesSelecionados;
  }
}