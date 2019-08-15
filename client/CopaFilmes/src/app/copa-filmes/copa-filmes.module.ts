import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { InicioCampeonatoComponent } from './inicio-campeonato/inicio-campeonato.component';
import { ResultadoCampeonatoComponent } from './resultado-campeonato/resultado-campeonato.component';
import { CardModule } from '../shared/card/card.module';

@NgModule({
  declarations: [InicioCampeonatoComponent, ResultadoCampeonatoComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    CardModule
  ]
})
export class CopaFilmesModule { }
