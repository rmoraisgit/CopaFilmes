import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InicioCampeonatoComponent } from './copa-filmes/inicio-campeonato/inicio-campeonato.component';
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
        component: InicioCampeonatoComponent
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