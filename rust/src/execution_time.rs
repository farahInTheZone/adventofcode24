pub fn measure<F: Fn()>(name: &str, f: F) {
    let start = std::time::Instant::now();
    f();
    let duration = start.elapsed();
    println!("{} took {}µs", name, duration.as_millis() * 1000);
}