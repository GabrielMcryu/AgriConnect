import { Injectable } from '@angular/core';
import { CanActivateFn, CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/authentication/auth.service';

// export const authGuard: CanActivateFn = (route, state) => {
//   return true;
// };

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private auth: AuthService, private router: Router) {}

  canActivate(): boolean {
    if (this.auth.isLoggedIn()) {
      return true;
    } else {
      alert('Please Login First');
      this.router.navigate(['login']);
      return false;
    }
  }
}
