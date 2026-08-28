import pygame
import random

pygame.init()

WIDTH, HEIGHT = 900, 600
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Ball Physics")

clock = pygame.time.Clock()

GRAVITY = 0.5
FPS = 60


class Ball:
    def __init__(self, x, y):
        self.x = x
        self.y = y

        self.radius = random.randint(10, 20)

        # Give each ball a tiny random horizontal push
        self.vx = random.uniform(-3, 3)
        self.vy = 0

        self.color = (
            random.randint(50, 255),
            random.randint(50, 255),
            random.randint(50, 255),
        )

        self.bounce = 0.82  # Energy retained after bounce

    def update(self):
        # Gravity
        self.vy += GRAVITY

        # Move
        self.x += self.vx
        self.y += self.vy

        # Floor
        if self.y + self.radius >= HEIGHT:
            self.y = HEIGHT - self.radius
            self.vy *= -self.bounce

            # Tiny friction
            self.vx *= 0.98

        # Left wall
        if self.x - self.radius <= 0:
            self.x = self.radius
            self.vx *= -self.bounce

        # Right wall
        if self.x + self.radius >= WIDTH:
            self.x = WIDTH - self.radius
            self.vx *= -self.bounce

    def draw(self, surface):
        pygame.draw.circle(surface, self.color, (int(self.x), int(self.y)), self.radius)


balls = []

running = True

while running:
    clock.tick(FPS)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

        elif event.type == pygame.MOUSEBUTTONDOWN:
            x, y = pygame.mouse.get_pos()
            balls.append(Ball(x, y))

    screen.fill((30, 30, 40))

    for ball in balls:
        ball.update()
        ball.draw(screen)

    pygame.display.flip()

pygame.quit()
