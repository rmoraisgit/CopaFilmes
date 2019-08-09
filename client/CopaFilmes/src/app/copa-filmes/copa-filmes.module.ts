import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InicioJogoComponent } from './inicio-jogo/inicio-jogo.component';
import { ResultadoJogoComponent } from './resultado-jogo/resultado-jogo.component';



@NgModule({
  declarations: [InicioJogoComponent, ResultadoJogoComponent],
  imports: [
    CommonModule
  ]
})
export class CopaFilmesModule { }
