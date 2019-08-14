import { Injectable } from '@angular/core';
import { CanActivate, RouterStateSnapshot, ActivatedRouteSnapshot, Router } from '@angular/router';


@Injectable({ providedIn: 'root' })
export class ResultadoCampeonatoGuard implements CanActivate {

    constructor(private router: Router) { }

    canActivate(route: ActivatedRouteSnapshot, stzate: RouterStateSnapshot) {

        if(!JSON.parse(localStorage.getItem('resultado-campeonato'))){
            this.router.navigate(['/inicio']);
            return false;
        }
        return true;
    }
}