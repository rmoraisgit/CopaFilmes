import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { InicioJogoComponent } from './inicio-jogo/inicio-jogo.component';
import { ResultadoJogoComponent } from './resultado-jogo/resultado-jogo.component';
import { CardModule } from '../shared/card/card.module';

@NgModule({
  declarations: [InicioJogoComponent, ResultadoJogoComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    CardModule
  ]
})
export class CopaFilmesModule { }
