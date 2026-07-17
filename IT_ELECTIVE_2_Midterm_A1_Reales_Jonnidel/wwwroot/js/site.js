// ================================================================
// Site.js - Portfolio Interactivity
// Handles scroll-spy for sidebar navigation and smooth scrolling
// ================================================================

(function () {
    'use strict';

    // ----------------------------------------------------------------
    // Scroll-Spy: Highlight active sidebar link based on scroll position
    // ----------------------------------------------------------------
    const sections = document.querySelectorAll('section[id]');
    const sidebarLinks = document.querySelectorAll('.sidebar-nav .nav-link');
    const mobileLinks = document.querySelectorAll('.sidebar-nav-mobile .nav-link');

    function updateActiveLink() {
        const scrollY = window.scrollY + 120;

        sections.forEach(function (section) {
            const sectionTop = section.offsetTop;
            const sectionHeight = section.offsetHeight;
            const sectionId = section.getAttribute('id');

            if (scrollY >= sectionTop && scrollY < sectionTop + sectionHeight) {
                // Update desktop sidebar
                sidebarLinks.forEach(function (link) {
                    link.classList.remove('active');
                    if (link.getAttribute('href') === '#' + sectionId) {
                        link.classList.add('active');
                    }
                });
                // Update mobile sidebar
                mobileLinks.forEach(function (link) {
                    link.classList.remove('active');
                    if (link.getAttribute('href') === '#' + sectionId) {
                        link.classList.add('active');
                    }
                });
            }
        });
    }

    window.addEventListener('scroll', updateActiveLink);
    window.addEventListener('load', updateActiveLink);

    // ----------------------------------------------------------------
    // Intersection Observer: Animate sections on scroll into view
    // ----------------------------------------------------------------
    const observerOptions = {
        root: null,
        rootMargin: '0px',
        threshold: 0.1
    };

    const observer = new IntersectionObserver(function (entries) {
        entries.forEach(function (entry) {
            if (entry.isIntersecting) {
                entry.target.classList.add('section-visible');
            }
        });
    }, observerOptions);

    sections.forEach(function (section) {
        section.classList.add('section-hidden');
        observer.observe(section);
    });

    // ----------------------------------------------------------------
    // Smooth scroll for sidebar links (desktop)
    // ----------------------------------------------------------------
    sidebarLinks.forEach(function (link) {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            var targetId = this.getAttribute('href');
            var target = document.querySelector(targetId);
            if (target) {
                target.scrollIntoView({ behavior: 'smooth', block: 'start' });
            }
        });
    });

})();
