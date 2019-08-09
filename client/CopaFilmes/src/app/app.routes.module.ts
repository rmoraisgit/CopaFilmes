import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InicioJogoComponent } from './copa-filmes/inicio-jogo/inicio-jogo.component';
import { ResultadoJogoComponent } from './copa-filmes/resultado-jogo/resultado-jogo.component';

const routes: Routes = [
    {
        path: '',
        component: InicioJogoComponent
    },
    {
        path: 'resultado',
        component: ResultadoJogoComponent
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