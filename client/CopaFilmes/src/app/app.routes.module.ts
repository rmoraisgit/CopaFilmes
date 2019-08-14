import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InicioJogoComponent } from './copa-filmes/inicio-jogo/inicio-jogo.component';
import { ResultadoCampeonatoComponent } from './copa-filmes/resultado-campeonato/resultado-campeonato.component';
import { ResultadoCampeonatoGuard } from './copa-filmes/resultado-campeonato/resultado-campeonato.guard';

const routes: Routes = [
    {
        path: '',
        redirectTo: "/inicio",
        pathMatch: 'full'
    },
    {
        path: 'inicio',
        component: InicioJogoComponent
    },
    {
        path: 'resultado',
        component: ResultadoCampeonatoComponent,
        canActivate: [ResultadoCampeonatoGuard] 
    }
]

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutesModule { }