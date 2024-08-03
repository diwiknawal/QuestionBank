// src/app/login/login.component.ts
import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import { User } from '../models/user.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  user: User = {
    username: '',
    password: '',
    role: ''
  };

  constructor(private userService: UserService) { }

  onSubmit(): void {
    this.userService.login(this.user).subscribe(
      response => {
        console.log('User logged in successfully:', response);
        // Redirect to dashboard or show success message
      },
      error => {
        console.error('Error logging in:', error);
      }
    );
  }
}
