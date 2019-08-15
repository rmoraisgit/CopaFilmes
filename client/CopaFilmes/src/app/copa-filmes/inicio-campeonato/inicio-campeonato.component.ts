import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';

import { Filme } from '../models/filme';
import { FilmeServices } from '../services/filme.service';
import { Router } from '@angular/router';

@Component({
  selector: 'cf-inicio-campeonato',
  templateUrl: './inicio-campeonato.component.html',
  styleUrls: ['./inicio-campeonato.component.css']
})
export class InicioCampeonatoComponent implements OnInit {

  filmes: Filme[] = [];
  filmesSelecionados: Filme[] = [];
  quantidadeFilmesSelecionados: number = 0;
  errors: any[] = [];

  @ViewChildren('cardsCheckBox') cardsCheckBox: QueryList<any>;

  constructor(private router: Router,
    private filmeService: FilmeServices) { }

  ngOnInit() {
    this.filmeService.obterFilmes().subscribe(filmes => {
      this.filmes = filmes;
    });
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

    if (this.quantidadeFilmesSelecionados >= 8)
      return true;

    return false;
  }

  private bloquearCheckBox() {

    this.cardsCheckBox.forEach(card => {

      if (!this.filmesSelecionados.some(f => f.id == card.idCheckBox)) {
        card.disabled = true;
      }
    });
  }

  private desbloquearCheckBox() {

    this.cardsCheckBox.forEach(card => {

      card.disabled = false;
    });
  }

  private checkBoxEstaBloqueado(): boolean {

    if (this.cardsCheckBox.some(c => c.disabled == true)) {
      return true;
    }

    else {
      return false;
    }
  }

  iniciarCampeonato() {

    localStorage.removeItem('resultado-campeonato');

    return this.filmeService.IniciarCampeonato(this.obterFilmesSelecionados())
      .subscribe(
        data => {
          localStorage.setItem('resultado-campeonato', JSON.stringify(data));
          this.router.navigate(['/resultado']);
        },
        fail => { this.errors = fail.error.errors }
      );
  }

  private obterFilmesSelecionados() {
    return this.filmesSelecionados;
  }

  fecharErros() {
    this.errors = [];
  }
}